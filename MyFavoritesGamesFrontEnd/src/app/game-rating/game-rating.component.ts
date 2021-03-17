import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GameService } from '../shared/game.service';

@Component({
  selector: 'app-game-rating',
  templateUrl: './game-rating.component.html',
  styleUrls: ['./game-rating.component.css']
})
export class GameRatingComponent implements OnInit {
  
  constructor(private service:GameService,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getRating();
  }

  getRating(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.service.getGame(id).subscribe();
  }

}
