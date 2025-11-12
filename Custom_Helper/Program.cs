// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 var today =DateHelper.formateDate(DateTime.Now);
Console.WriteLine(today);

var curDate =new Dateformat();
var res  =  curDate.Date(DateTime.Now)  ;
Console.WriteLine(res);

public class DateHelper
{
    public static string formateDate(DateTime date,string formate = "dd-MM-yyyy")
    {
        return date.ToString(formate);
    }

}





public class Dateformat
{
    public string Date(DateTime date, string formateDate = "yyyy-MM-dd")
    {
        return date.ToString(formateDate);
    }
}