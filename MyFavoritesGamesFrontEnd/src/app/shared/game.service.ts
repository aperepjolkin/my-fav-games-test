import { Injectable } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
import { Game } from './game.model';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor() { }

  readonly baseURL = 'https://localhost:44372/games'
  data: Game = new Game();
}
