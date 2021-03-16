import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Game } from './game.model';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:44372/gamesList20'
  data: Game = new Game();

  getGamesList() {
     return this.http.get(this.baseURL);
  }
}
