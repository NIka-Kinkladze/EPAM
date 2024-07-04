using System;

namespace vehicles
{
    // InitializationException - an exception if it is impossible to initialize a car model.
    public class InitializationException : Exception
    {
        public InitializationException(string message) : base(message)
        {
        }
    }

    // AddException - an exception if it is impossible to add a car model;
    public class AddException : Exception
    {
        public AddException(string message) : base(message)
        {
        }
    }

    // GetAutoByParameterException - for the GetAutoByParameter (string parameter, string value) method
    // an exception if it is impossible to find the model by the specified parameter.
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message) : base(message)
        {
        }
    }

    // UpdateAutoException - an exception if it is impossible to replace a car.
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException(string message) : base(message)
        {
        }
    }

    // RemoveAutoException - an exception if it is impossible to remove a car.
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException(string message) : base(message)
        {
        }
    }
}