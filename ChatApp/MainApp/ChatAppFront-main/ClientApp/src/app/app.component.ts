import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BaseComponent } from './views/layout/base/base.component';
import { FooterComponent } from './views/layout/footer/footer.component';
import { SidebarComponent } from './views/layout/sidebar/sidebar.component';
import { ChatComponent } from './views/layout/chat/chat.component';
import { ChatpageComponent } from './views/pages/chatpage/chatpage.component';
import { SignalRService } from './services/signalr/signal-r.service';




@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule, 
    RouterModule,
    HomeComponent,
    BaseComponent,
    FooterComponent,
    SidebarComponent,
    ChatComponent,
    ChatpageComponent
    
 
  ],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientApp';
  constructor(private signalRService : SignalRService){

  }

  ngOnInit(){
    let user =  localStorage.getItem('username');
    this.signalRService.startConnection(user);
  }
  
}
