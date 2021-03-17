import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Game } from './game.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:44372/gamesList20';

  readonly gamesListDbURL = 'https://localhost:44372/api/Games/GetAll';
  readonly gamesPostDbURL = 'https://localhost:44372/api/Games/GetAll';
  readonly gameURL = 'https://localhost:44372/api/Games/';

  data: Game = new Game();

  getGamesList() {
     return this.http.get(this.baseURL);
  }
  // Show list from table
  getGamesDB() {
    return this.http.get<Game[]>(this.gamesListDbURL);
  }

  getGame(id:number) {
    return this.http.get<Game>(`${this.gameURL}${id}`);
  }

  saveGameRating() {
    return this.http.post(this.gamesPostDbURL,{
      "id": 39046,
      "title": "New Gane",
      "rating": 6,
      "email": "abugsbunnny@gmail.com",
      "comment": "string"
    });
  }
}
