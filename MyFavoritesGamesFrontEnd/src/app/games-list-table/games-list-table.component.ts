import { Component, OnInit } from '@angular/core';
import { GameService } from '../shared/game.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-games-list-table',
  templateUrl: './games-list-table.component.html',
  styleUrls: ['./games-list-table.component.css']
})
export class GamesListTableComponent implements OnInit {

  public data;
  public rowData;
  constructor(public service:GameService,private datePipe: DatePipe) { }
  columnDefs = [
      { field: 'Title', filter: true, checkboxSelection: true },
      { field: 'Year', sortable: true },
      { field: 'Average Rating',sortable: true}
  ];

  ngOnInit(): void {
    this.service.getGamesList().subscribe(
      res => {
        console.log(res);
        let gamesList = [];
        this.data = res;
        this.data.forEach(element => {
          gamesList.push({Title: element.Name,Year: this.datePipe.transform(element.FirstReleaseDate),'Average Rating':element.Rating})
        });
        this.rowData = gamesList;
      
      },
      err => {console.log(err);}
    );
  }

}
