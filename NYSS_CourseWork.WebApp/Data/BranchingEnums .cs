namespace NYSS_CourseWork.WebApp.Data
{
    public class BranchingEnums
    {  
        public enum InputChoise
        {
            none,
            fromTxt,
            fromKeyboard
        }

        public enum OutputVar
        {
            none,
            outTxt,
            onMonitor,
        }

        public enum CryptFunc
        {
            none,
            encrypt,
            decrypt
        }
        public enum CryptLanguage
        {
           Russian,
           English
        }
    }
}
