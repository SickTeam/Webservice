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

    /// <param name="gameId"></param>
    /// <returns>GameIdGetOKResponseContent</returns>
    public IHttpActionResult Get([FromUri] string gameId) {
      // TODO: implement Get - route: games/{gameId}
      // var result = new GameIdGetOKResponseContent();
      // return Ok(result);
      return Ok();
    }

    /// <param name="gameId"></param>
    /// <returns>CommitGetOKResponseContent</returns>
    public IHttpActionResult GetCommit([FromUri] string gameId) {
      // TODO: implement GetCommit - route: games/{gameId}/commit
      // var result = new CommitGetOKResponseContent();
      // return Ok(result);
      return Ok();
    }

    /// <param name="gameId"></param>
    /// <returns>IList<GuessesGetOKResponseContent></returns>
    public IHttpActionResult GetGuesses([FromUri] string gameId) {
      // TODO: implement GetGuesses - route: games/{gameId}/commit/guesses
      // var result = new IList<GuessesGetOKResponseContent>();
      // return Ok(result);
      return Ok();
    }

    /// <param name="playerId"></param>
    /// <param name="gameId"></param>
    /// <returns>PlayerIdGetOKResponseContent</returns>
    public IHttpActionResult GetByPlayerId([FromUri] string playerId, [FromUri] string gameId) {
      // TODO: implement GetByPlayerId - route: games/{gameId}/commit/guesses/{playerId}
      // var result = new PlayerIdGetOKResponseContent();
      // return Ok(result);
      return Ok();
    }

    /// <param name="playerspostrequestcontent"></param>
    /// <param name="gameId"></param>
    /// <returns>PlayersPostOKResponseContent</returns>
    public IHttpActionResult PostPlayers(Models.PlayersPostRequestContent playerspostrequestcontent, [FromUri] string gameId) {
      // TODO: implement PostPlayers - route: games/{gameId}/players
      // var result = new PlayersPostOKResponseContent();
      // return Ok(result);
      return Ok();
    }

    /// <summary>
    /// Kick a player
    /// </summary>
    /// <param name="playerId"></param>
    /// <param name="gameId"></param>
    public IHttpActionResult Delete([FromUri] string playerId, [FromUri] string gameId) {
      // TODO: implement Delete - route: games/{gameId}/players/{playerId}
      return Ok();
    }

  }
}
