import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TopFiveGamesComponent } from './top-five-games/top-five-games.component';
import { GamesListTableComponent } from './games-list-table/games-list-table.component';
import { HttpClientModule } from '@angular/common/http';
import { AgGridModule } from 'ag-grid-angular';
import { DatePipe } from '@angular/common';
import { GamesRatingTableComponent } from './games-rating-table/games-rating-table.component';
import { GameRatingComponent } from './game-rating/game-rating.component';
import { AppRoutingModule } from './app-routing.module';
import { GamesDashboardComponent } from './games-dashboard/games-dashboard.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    TopFiveGamesComponent,
    GamesListTableComponent,
    GamesRatingTableComponent,
    GameRatingComponent,
    GamesDashboardComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AgGridModule.withComponents([]),
    AppRoutingModule,
    FormsModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
  