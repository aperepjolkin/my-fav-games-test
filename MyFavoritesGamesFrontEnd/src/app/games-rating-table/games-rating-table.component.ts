import { Component, OnInit } from '@angular/core';
import { GameService } from '../shared/game.service';


@Component({
  selector: 'app-games-rating-table',
  templateUrl: './games-rating-table.component.html',
  styleUrls: ['./games-rating-table.component.css']
})
export class GamesRatingTableComponent implements OnInit {

  constructor(public service:GameService) { }
  public data;
  public rowData;
  public gamesList = [];
  ngOnInit(): void {
    this.service.getGamesDB().subscribe(
      res => {
        console.log(res);
       
        this.gamesList = res;
   /*      this.data.forEach(element => {
          this.gamesList.push({Id:element.PublicGameID,Title: element.Name,Rating:element.Rating})
        });
        this.rowData = this.gamesList; */
      },
      err => {console.log(err);}
    );

    
  }

  postRating(): void {
    this.service.saveGameRating().subscribe(
      res => {
        console.log(res);
    
      },
      err => {console.log(err);}
    );
  }
}
