using System.Reflection.Metadata.Ecma335;

namespace ML
{
    public class Result
    {
        public bool Correct { get; set; }
        public Object Object { get; set; }
        public List<object> Objects { get; set; }
        public string ErrorMessage { get; set; }
        public Exception exception { get; set; }
    }
}