namespace Pharmakonzern
{
    // Interface defining a contract for getting valid user input of type T
    public interface IUserInput<T>
    {
        T GetValidInput(); // Method signature for obtaining valid input of type T
    }

    // Class implementing the IUserInput interface for handling user input of type T
    public class UserInput<T> : IUserInput<T>
    {
        private readonly Func<T> _parseMethod; // Delegate for parsing input of type T
        private readonly string _inputMessage; // Message displayed for user input
        private readonly string _errorMessage; // Error message displayed on input failure

        // Constructor initializing the UserInput object
        public UserInput(Func<T> parseMethod, string inputMessage, string errorMessage)
        {
            _parseMethod = parseMethod ?? throw new ArgumentNullException(nameof(parseMethod));
            _inputMessage = inputMessage ?? throw new ArgumentNullException(nameof(inputMessage));
            _errorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
        }

        // Method to get valid user input of type T
        public T GetValidInput()
        {
            while (true)
            {
                try
                {
                    Console.Write(_inputMessage); // Prompting the user for input
                    return _parseMethod(); // Attempting to parse the user input of type T
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid value.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Input cannot be null. Please enter a valid value.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input exceeds the valid range. Please enter a valid value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{_errorMessage}: {ex.Message}"); // Displaying custom error message
                }
            }
        }
    }
}
