using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftGrow
{
   public class MyMessages
    {

      public enum MessageType
       {
           SaveRecord=0,
           UpdateRecord=1,
           DeleteRecord=2,           
           Error=3,
           MissingInfo=4,
           General=5
       };

      DAL.Settings objDal = new DAL.Settings();
      Speak say = new Speak();
      bool vAllow;

      public MyMessages()
       {           
           objDal.connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
           vAllow = Convert.ToBoolean(objDal.GetSettingValue(DAL.Settings.ProSettings.MsgSounds));
        }
      public void ShowMessage(MessageType mType,string error="" )
      {
          if (mType == MessageType.SaveRecord)
          {
              if (vAllow) say.SayIt("Record Saved Successfully."); 
              MessageBox.Show("Record Saved Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              
          }
          else if (mType == MessageType.UpdateRecord)
          {
              if (vAllow) say.SayIt("Record Updated Successfully."); 
              MessageBox.Show("Record Updated Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              
          }
          else if (mType == MessageType.DeleteRecord)
          {
              if (vAllow) say.SayIt("Record Deleted Successfully."); 
              MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              
          }
          else if (mType == MessageType.Error)
          {
              MessageBox.Show(error, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //if (vAllow) say.SayIt(error); 
          }
          else if (mType == MessageType.MissingInfo)
          {
              if (vAllow) say.SayIt(error); 
              MessageBox.Show(error, "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);              
          }
          else if (mType == MessageType.General)
          {
              if (vAllow) say.SayIt(error); 
              MessageBox.Show(error, "Soft Grow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);              
          }
          
      }
      public bool ConfrmDelMsg()
      {
          bool result=false;
          if (vAllow) say.SayIt("Are you Sure To Delete!!!"); 
          DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);          
          if (dMsg == DialogResult.No)
          {
              result = false;
          }
          else if (dMsg == DialogResult.Yes)
          {
              result = true;
          }

          return result;
      }

      public bool ConfrmPrintMsg()
      {
          bool result = false;
          if (vAllow) say.SayIt("Do you want To Print!!!");
          DialogResult dMsg = MessageBox.Show("Do you want To Print!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (dMsg == DialogResult.No)
          {
              result = false;
          }
          else if (dMsg == DialogResult.Yes)
          {
              result = true;
          }

          return result;
      }
    }
}
