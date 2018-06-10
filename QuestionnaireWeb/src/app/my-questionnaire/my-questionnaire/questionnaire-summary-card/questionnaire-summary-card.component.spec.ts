import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionnaireSummaryCardComponent } from './questionnaire-summary-card.component';

describe('QuestionnaireSummaryCardComponent', () => {
  let component: QuestionnaireSummaryCardComponent;
  let fixture: ComponentFixture<QuestionnaireSummaryCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestionnaireSummaryCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestionnaireSummaryCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
