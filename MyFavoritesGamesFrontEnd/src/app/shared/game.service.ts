import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Game } from './game.model';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:44372/gamesList20'

  readonly gamesListDbURL = 'https://localhost:44372/api/Games/GetAll';
  readonly gamesPostDbURL = 'https://localhost:44372/api/Games/GetAll'


  //https://localhost:44372/api/Games?id=39047

  data: Game = new Game();

  getGamesList() {
     return this.http.get(this.baseURL);
  }
  // Show list from table
  getGamesDB() {
    return this.http.get<Game[]>(this.gamesListDbURL);
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
