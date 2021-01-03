import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { BoardComponent } from './board/board.component';
import { AdminComponent } from './admin/admin.component';
import { BoardService } from './services/board.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    BoardComponent,
    AdminComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: BoardComponent, pathMatch: 'full' },
      { path: 'admin', component: AdminComponent }
    ])
  ],
  providers: [BoardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
