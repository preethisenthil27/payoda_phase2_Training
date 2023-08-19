import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
ServerId:number=1001;
ServerStatus:string ="available";
addNewUser:boolean=false;
ServerCreated: String="not yet";
ServerName:string ="";
ServerList=['sql','oracle'];

// onServerNameEntry(event:Event)
// {
//   console.log(event);
//   this.ServerName=(<HTMLInputElement>event.target).value;
// }
constructor()
{
  setTimeout(()=>{
    this.addNewUser=true;
  },5000);
}
OnServerCreation(){
  return this.ServerCreated="created";
  this.ServerList.push(this.ServerName);
}

getServerId(){
  return this.ServerId;
}
getServerStatus(){
  return this.ServerStatus;
}
}
