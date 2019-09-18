using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Messages
    {
        public static string MsgBoxTitle = "Calculator";
        public static string ExitMsg = "Are you sure you want to exit ?";
        public static string ErrorMsgTitle = "* Please Correct the Following Errors :";
        public static string RequiredMsg = "Please Fill the Required field";
        public static string LogoffMsg = "Are you sure you want to Logoff?";
        public static string FailLogin = "Login failed. Invalid login detail. Please Try Again!";
        public static string ExceptionMsg = "Please try again or Contact to support team.";
        public static string NoRecordMsg = "No record found.";
        public static string SaveSuccessMsg = "Record saved successfully!";
        public static string SelectOneRecordMsg = "Please select atleast one {0}!";
        public static string DeleteMsg = "Are you sure, you want to delete this {0}?";
        public static string DuplicateMsg = "{0} is already exists! Please enter different {0}.";
        public static string ReferenceExistMsg = "{0} reference used in another place, you cannot perform delete action.";
        public static string ApproveMsg = "Are you sure, you want to approve this {0}?";
        public static string SelectMsg = "Please select {0}!";
        public static string AlreadyAddedCourse = "{0} course already added in {1} Student ID. Please enter different value.";
        public static string NotAddedCourse = "{0} course not added in {1} Student ID. Please add course in student ID.";
    }
}
