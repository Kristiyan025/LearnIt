namespace LearnIt.Validation
{
    using LearnIt.Models;
    using System.Linq;

    public static class DateValidator
    {
        public static void UpateCourseEndPoints(CourseDataModel c)
        {
            if(c.Lectures.Count != 0)
            {
                c.StartDate = c.Lectures.Select(x => x.StartDate).Min();
                c.EndDate = c.Lectures.Select(x => x.StartDate).Max();
            }
            else
            {
                c.StartDate = c.EndDate = new System.DateTime();
            }
        }
    }
}
