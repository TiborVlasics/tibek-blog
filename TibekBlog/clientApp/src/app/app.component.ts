import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { tap, map } from 'rxjs/operators';

import { AppInitService } from './app-init.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'clientApp';
  value$;

  constructor(
    private appInitService: AppInitService,
    private http: HttpClient
  ) { }

  ngOnInit() {
    const api = this.appInitService.getApiUrl();
    console.log(api);
    this.value$ = this.http.get(`${api}/posts`)
      .pipe(
        tap(val => console.log(val)),
        map(val => val[0])
      );
  }
}
