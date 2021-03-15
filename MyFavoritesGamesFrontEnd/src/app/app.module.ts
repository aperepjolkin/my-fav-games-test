import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TopFiveGamesComponent } from './top-five-games/top-five-games.component';
import { GamesListTableComponent } from './games-list-table/games-list-table.component';

@NgModule({
  declarations: [
    AppComponent,
    TopFiveGamesComponent,
    GamesListTableComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
  