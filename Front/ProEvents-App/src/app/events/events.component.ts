import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = [
    {
      Subject: 'Angular',
      Local: 'Dourados'
    },
    {
      Subject: 'Programação c#',
      Local: 'Campo Grande'
    },
    {
      Subject: 'Programação Web',
      Local: 'Antônio João'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
