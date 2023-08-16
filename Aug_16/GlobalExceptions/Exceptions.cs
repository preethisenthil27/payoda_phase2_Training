namespace Jwt.GlobalExceptions


{
    public class StudentDetailsExceptions : Exception
    {
        public static List<string> StudentnotFoundException { get; } =
        new List<string>
            {
                "Student Not Found",
                "User not Found",
                ""

            };

    }
}
