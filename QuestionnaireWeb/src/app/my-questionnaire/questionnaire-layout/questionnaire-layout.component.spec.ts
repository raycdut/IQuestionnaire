
import { fakeAsync, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionnaireLayoutComponent } from './questionnaire-layout.component';

describe('QuestionnaireLayoutComponent', () => {
  let component: QuestionnaireLayoutComponent;
  let fixture: ComponentFixture<QuestionnaireLayoutComponent>;

  beforeEach(fakeAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestionnaireLayoutComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QuestionnaireLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
