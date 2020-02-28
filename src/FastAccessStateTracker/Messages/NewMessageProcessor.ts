import { CommandContext } from "./CommandContext";

export class NewMessageProcessor
{
  private static _CommandContext : CommandContext = new CommandContext();

  public static ParseMessage(json: any, connection: WebSocket) : void
  {    
    let commandToExecute : string = json.command;
    //EDIT THIS TO RETURN JSON
    this._CommandContext.ExecuteCommand(commandToExecute, json, connection);
  }
}