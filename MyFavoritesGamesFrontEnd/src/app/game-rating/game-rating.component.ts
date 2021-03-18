import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Game } from '../shared/game.model';
import { GameService } from '../shared/game.service';

@Component({
  selector: 'app-game-rating',
  templateUrl: './game-rating.component.html',
  styleUrls: ['./game-rating.component.css']
})
export class GameRatingComponent implements OnInit {
  
  constructor(public service:GameService,
              private route: ActivatedRoute) { }
  public game:Game = new Game();
  
  
  ngOnInit(): void {
    this.getRating();
    
  }

  getRating(): void {
    const id = +this.route.snapshot.paramMap.get('id');
     this.service.getGame(id).subscribe(result => {
     this.game = result;
     
    });
  }

  onSubmit(form:NgForm): void {
    this.service.saveGameRating().subscribe(
      res => {
    
      },
      err => { console.log(err);}
    )
  }

}
