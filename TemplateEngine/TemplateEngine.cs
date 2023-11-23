using System;
using System.Collections.Generic;

namespace TemplateEngine;

public class TemplateEngine
{
   string template;

   string variableName;
   string variableValue;
   private Dictionary<string,string> nameAndValue;

   public TemplateEngine()
        {
            nameAndValue = new Dictionary<string, string>();
            template = string.Empty;
        }
   

   public string parse(){

      foreach (var kvp in nameAndValue)
            {
                template = template.Replace("{" + kvp.Key + "}", kvp.Value);
            }
            return template;
   }

   public void setTemplate(string template){

       this.template = template;
   }

   public void setVariables(string variableName, string variableValue){
       
       nameAndValue[variableName]=variableValue;
   }
}
