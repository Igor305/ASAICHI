import { Injectable } from '@angular/core';
import { DatePipe } from '@angular/common';

@Injectable({
  providedIn: 'root',
})

export class BoardService {

  private date : DatePipe

  constructor() { }

  public getdates() {
    const dates = [];
    let count = 0;
    do {
      const day = new Date().getDate() - count;
      let mount = new Date().getMonth();
      mount++;
      count++;
      dates.push(day + '.' + mount);
    } while (count < 7);
    return dates;
  }
}
