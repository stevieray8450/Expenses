using System;
namespace TestAPI.Data
{
    public interface IExpensesDa
    {
        bool UploadFile(object csvFile);
    }
}
