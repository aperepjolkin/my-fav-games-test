import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GamesListTableComponent } from './games-list-table.component';

describe('GamesListTableComponent', () => {
  let component: GamesListTableComponent;
  let fixture: ComponentFixture<GamesListTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GamesListTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GamesListTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
