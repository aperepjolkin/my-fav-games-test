import { Injectable } from '@angular/core';
import { HttpClient, } from '@angular/common/http';
import { Game } from './game.model';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:44372/gamesList20';

  readonly gamesListDbURL = 'https://localhost:44372/api/Games/GetAll';
  readonly gamesPostDbURL = 'https://localhost:44372/api/Games';
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
    console.log()
    return this.http.get<Game> (`${this.gameURL}${id}`);
  }

 saveGameRating() {
    return this.http.post(this.gamesPostDbURL, this.data
     /* {
    
      /* "id": 39046,
      "title": "New Gane",
      "rating": 6,
      "email": "abugsbunnny@gmail.com",
      "comment": "string" 
    }*/);
  }
}
