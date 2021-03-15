import { Component, OnInit } from '@angular/core';
import { GameService } from '../shared/game.service';

@Component({
  selector: 'app-games-list-table',
  templateUrl: './games-list-table.component.html',
  styleUrls: ['./games-list-table.component.css']
})
export class GamesListTableComponent implements OnInit {

  constructor(public service:GameService) { }

  ngOnInit(): void {
  }

}
