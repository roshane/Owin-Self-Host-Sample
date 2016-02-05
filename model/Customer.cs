namespace Owin_Self_Host_Sample.model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Customer{{" +
                                 " FirstName : {0}," +
                                 " LastName : {1}," +
                                 " Email : {2}," +
                                 " Age : {3}" +
                                 " }}",
                FirstName, LastName, Email, Age);
        }
    }
}