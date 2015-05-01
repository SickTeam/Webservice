// Template: Controller Implementation (ApiControllerImplementation.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using Webservice.ApiV1.Models;

namespace Webservice.ApiV1 {
  public partial class GamesController : IGamesController {

    /// <param name="gamespostrequestcontent"></param>
    /// <returns>GamesPostOKResponseContent</returns>
    public IHttpActionResult Post(Models.GamesPostRequestContent gamespostrequestcontent) {
      // TODO: implement Post - route: games/
      // var result = new GamesPostOKResponseContent();
      // return Ok(result);
      return Ok();
    }

    /// <param name="gameidplayerspostrequestcontent"></param>
    /// <param name="gameId"></param>
    public IHttpActionResult PostByGameIdPlayers(Models.GameIdPlayersPostRequestContent gameidplayerspostrequestcontent, [FromUri] string gameId) {
      // TODO: implement PostByGameIdPlayers - route: games/{gameId}/players
      return Ok();
    }

  }
}
