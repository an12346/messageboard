using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageBoardClient.Models
{
  public class EndUser
  {
    public int EndUserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public static List<EndUser> GetEndUsers()
    {
      var apiClassTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<EndUser> endUserList = JsonConvert.DeserializeObject<List<EndUser>>(jsonResponse.ToString());
      return endUserList;
    }

  }
}
