import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TopFiveGamesComponent } from './top-five-games/top-five-games.component';
import { GamesListTableComponent } from './games-list-table/games-list-table.component';
import { HttpClientModule } from '@angular/common/http';
import { AgGridModule } from 'ag-grid-angular';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    TopFiveGamesComponent,
    GamesListTableComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AgGridModule.withComponents([])
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
  