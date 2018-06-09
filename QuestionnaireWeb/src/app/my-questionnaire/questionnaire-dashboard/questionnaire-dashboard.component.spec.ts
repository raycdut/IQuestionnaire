
import { fakeAsync, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionnaireDashboardComponent } from './questionnaire-dashboard.component';

describe('QuestionnaireDashboardComponent', () => {
  let component: QuestionnaireDashboardComponent;
  let fixture: ComponentFixture<QuestionnaireDashboardComponent>;

  beforeEach(fakeAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestionnaireDashboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QuestionnaireDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
