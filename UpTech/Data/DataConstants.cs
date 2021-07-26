namespace UpTech.Data
{ 
    public class DataConstants 
    {
        public class User
        {
            public const int FirstNameMaxLength = 250;
            
            public const int LastNameMaxLength = 250;
            
            public const int FirstAddressMaxLength = 250;

            public const int SecondAddressMaxLength = 250;

            public const int PostCodeMaxLength = 25;
        }
        public class CategoryConstraint
        {
            public const int TitleMaxLength = 200;

            public const int TitleMinLength = 2;
        }

        public class CategoryItemConstraint
        {
            public const int TitleMaxLength = 200;
            
            public const int TitleMinLength = 2;
        }
        
        public class MediaTypeConstraint
        {
            public const int TitleMaxLength = 200;
            
            public const int TitleMinLength = 2;
        }

        public class ContentConstraint
        {
            public const int TitleMaxLength = 200;
            
            public const int TitleMinLength = 2;
        }
    }
}