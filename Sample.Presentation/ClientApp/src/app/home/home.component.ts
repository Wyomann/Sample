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
    // Normally I wouldn't hardcode in a url value and I'd inject
    // an ApiService to do the http calls but for brevity I'm just
    // calling the hello world API here.
    this.http.get("http://localhost:61390/api/values")
      .subscribe(data => {
        this.responseValue = data;
      });
  }
}
