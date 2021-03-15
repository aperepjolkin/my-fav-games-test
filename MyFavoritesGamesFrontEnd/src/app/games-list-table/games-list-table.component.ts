import { Component, OnInit } from '@angular/core';
import { GameService } from '../shared/game.service';

@Component({
  selector: 'app-games-list-table',
  templateUrl: './games-list-table.component.html',
  styleUrls: ['./games-list-table.component.css']
})
export class GamesListTableComponent implements OnInit {

  public data;
  constructor(public service:GameService) { }

  ngOnInit(): void {
    this.service.getGamesList().subscribe(
      res => {
        console.log(res);
        this.data = res ;
      },
      err => {console.log(err);}
    );
  }

}
