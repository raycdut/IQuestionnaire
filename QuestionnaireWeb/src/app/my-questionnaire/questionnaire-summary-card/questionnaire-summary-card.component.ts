import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-questionnaire-summary-card',
  templateUrl: './questionnaire-summary-card.component.html',
  styleUrls: ['./questionnaire-summary-card.component.css']
})
export class QuestionnaireSummaryCardComponent implements OnInit {
  @Input()
  public questionnaireSummary: any;
  constructor() { }

  ngOnInit() {
  }

  deleteQuestionnaire() {
    console.log('questionnaire deleted');
  }
}
