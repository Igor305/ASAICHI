import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Inject } from '@angular/core';
import { BoardService } from '../services/board.service';
import { BoardModel } from '../models/board.model';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css']
})
export class BoardComponent implements OnInit{

  public boards: BoardModel[];
  public dates: string[];

  constructor(public boardService : BoardService, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BoardModel[]>(baseUrl + 'board').subscribe(result => {
      this.boards = result;
    }, error => console.error(error));}

  ngOnInit() { this.dates = this.boardService.getdates(); }
}
