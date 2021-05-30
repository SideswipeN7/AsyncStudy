using System;
using System.Collections.Generic;
using Lessons.Common.Models;
using Lessons.Runner.Interfaces;

namespace Lessons.Runner.Abstraction
{
    public abstract class AbstractRunner<T> : IRunner<T> where T : BaseConfiguration
    {
        private Models.Range range;
        private bool isValidInput;
        protected int selectedActionIndex;
        protected IReadOnlyCollection<T> configurations;

        public void Initialize(IReadOnlyCollection<T> configurations)
        {
            isValidInput = false;
            selectedActionIndex = 0;
            range = Models.Range.CreateFromLength(configurations.Count);
            this.configurations = configurations;
        }

        public void Run()
        {
            while (true)
            {
                ExecuteInLoop();
            }
        }

        protected void ExecuteInLoop()
        {
            do
            {
                WriteInfoToUser();
                var userInput = GetUserInput();
                isValidInput = IsValidInput(userInput);
                if (isValidInput)
                {
                    SetSelectedAction(userInput);
                }
            }
            while (!isValidInput);

            ExecuteOnSelectedItem();
        }


        private void WriteInfoToUser()
        {
            WriteEmptyLine();
            WriteSynopsis();
            WriteOptions();
            WriteSeparator();
        }

        private static void WriteEmptyLine() => Console.WriteLine();

        protected abstract void WriteSynopsis();

        private void WriteOptions()
        {
            for (int i = range.Start; i <= range.End; i++)
            {
                WriteOption(i);
            }
        }

        protected abstract void WriteOption(int rangeOptionIndex);

        private static void WriteSeparator() => Console.WriteLine("--------------------------");

        private static string GetUserInput() => Console.ReadLine();

        private bool IsValidInput(string userInput)
        {
            var isNumber = ParseUserInput(userInput, out int parsedUserInput);
            if (isNumber)
            {
                return IsInRange(parsedUserInput);
            }

            return false;
        }

        private static bool ParseUserInput(string userInput, out int parsedUserInput) => int.TryParse(userInput, out parsedUserInput);

        private bool IsInRange(int userInput) => userInput >= range.Start && userInput <= range.End;

        private void SetSelectedAction(string userInput) => selectedActionIndex = int.Parse(userInput) - 1;

        protected abstract void ExecuteOnSelectedItem();
    }
}