using UiPath.CodedWorkflows.DescriptorIntegration;

namespace REF_PracticaHash.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_ACME_System_1___Log_In
        {
            static string _reference = "9NJMFWqweUaRipu292g8ow/9I_COsvVh0iAfxurQa5tDA";
            public static _Implementation.___Chrome_ACME_System_1___Log_In.__Chrome_ACME_System_1___Log_In Chrome_ACME_System_1___Log_In { get; private set; } = new _Implementation.___Chrome_ACME_System_1___Log_In.__Chrome_ACME_System_1___Log_In();
        }
    }
}

namespace REF_PracticaHash._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In
    {
        public class __Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "9NJMFWqweUaRipu292g8ow/j9ZKXFHPgUuISX8ZHYHrcQ",
                    DisplayName = "Email",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In
    {
        public class __Login : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Login(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "9NJMFWqweUaRipu292g8ow/FZ7qQdBVF0qDgSP0Lq3RAA",
                    DisplayName = "Login",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "9NJMFWqweUaRipu292g8ow/pXG1uDSPek2VakbNSYjGCg",
                    DisplayName = "Password",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_ACME_System_1___Log_In
    {
        public class __Chrome_ACME_System_1___Log_In : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_ACME_System_1___Log_In()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "9NJMFWqweUaRipu292g8ow/dsDn9R233ke__kCmwdbqnw",
                    DisplayName = "Chrome ACME System 1 - Log In",
                    Screen = this
                };
                Email = new _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Email(this, null);
                Login = new _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Login(this, null);
                Password = new _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Password(this, null);
            }

            public _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Email Email { get; private set; }
            public _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Login Login { get; private set; }
            public _Implementation.___Chrome_ACME_System_1___Log_In._Chrome_ACME_System_1___Log_In.__Password Password { get; private set; }
        }
    }
}