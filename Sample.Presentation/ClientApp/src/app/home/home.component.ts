import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  responseValue;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get("http://localhost:61390/api/values")
      .subscribe(data => {
        this.responseValue = data;
      });
  }
}
