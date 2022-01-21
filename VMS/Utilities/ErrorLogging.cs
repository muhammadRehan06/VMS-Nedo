using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS.Utilities
{
    public static class ErrorLogging
    {
        public static bool Add(string ErrorMsg, string InnerErrorMsg, DateTime ErrorDate, string UserName, string ControllerName, string MethodName)
        {
            try
            {
                using (VmsEntities db = new VmsEntities())
                {
                    ErrorLogMaster errorLog = new ErrorLogMaster();
                    errorLog.ControllerName = ControllerName;
                    errorLog.ErrorDateTime = ErrorDate;
                    errorLog.ErrorMessage = ErrorMsg;
                    if (InnerErrorMsg != null)
                    {
                        errorLog.InnerErrorMessage = InnerErrorMsg;
                    }
                    errorLog.MethodName = MethodName;
                    errorLog.UserName = UserName;
                    db.ErrorLogMasters.Add(errorLog);
                    db.SaveChanges();
                }
            }
            catch
            {

                throw;
            }
            return false;

        }


        //internal static void Add(string message, DateTime now, object p, string v1, string v2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}