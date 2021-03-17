import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameRatingComponent } from './game-rating/game-rating.component';
import { GamesDashboardComponent } from './games-dashboard/games-dashboard.component';
import { GamesListTableComponent } from './games-list-table/games-list-table.component';
import { GamesRatingTableComponent } from './games-rating-table/games-rating-table.component';

const routes: Routes = [
  { path: '', redirectTo: '/gamesdashboard', pathMatch: 'full' },
  { path: 'gamesdashboard', component: GamesDashboardComponent },
  { path: 'gameslist', component: GamesRatingTableComponent },
  { path: 'publicgameslist', component: GamesListTableComponent },
  { path: 'rating/:id', component: GameRatingComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }