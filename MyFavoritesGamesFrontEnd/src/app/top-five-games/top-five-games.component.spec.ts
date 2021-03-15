import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopFiveGamesComponent } from './top-five-games.component';

describe('TopFiveGamesComponent', () => {
  let component: TopFiveGamesComponent;
  let fixture: ComponentFixture<TopFiveGamesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopFiveGamesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TopFiveGamesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
