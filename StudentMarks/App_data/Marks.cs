namespace StudentMarks.App_data
{
    internal class Marks
    {
        public string SubjectName { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal ObtainedNumber { get; set; }
        public string Status   // => (ObtainedNumber > 0) && (TotalNumber > 0) && (ObtainedNumber / TotalNumber) * 100 >= 33 ? "PASS" : "FAIL";
        {
            get
            {
                if (ObtainedNumber == 0)
                    return "";

                if (TotalNumber == 0)
                    return "";

                try
                {
                    return (ObtainedNumber / TotalNumber) * 100 >= 33 ? "PASS" : "FAIL";
                }
                catch (System.Exception)
                {

                    return "";
                }               
            }
        }
           
    }
}
