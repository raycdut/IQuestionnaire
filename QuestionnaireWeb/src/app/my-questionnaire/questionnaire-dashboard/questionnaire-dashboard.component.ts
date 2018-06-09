import { Component } from '@angular/core';

@Component({
  selector: 'app-questionnaire-dashboard',
  templateUrl: './questionnaire-dashboard.component.html',
  styleUrls: ['./questionnaire-dashboard.component.css']
})
export class QuestionnaireDashboardComponent {
  cards = [
    { title: 'Card 1', cols: 2, rows: 1 },
    { title: 'Card 2', cols: 1, rows: 1 },
    { title: 'Card 3', cols: 1, rows: 2 },
    { title: 'Card 4', cols: 1, rows: 1 }
  ];
}
