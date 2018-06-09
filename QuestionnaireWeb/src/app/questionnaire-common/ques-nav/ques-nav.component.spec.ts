
import { fakeAsync, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuesNavComponent } from './ques-nav.component';

describe('QuesNavComponent', () => {
  let component: QuesNavComponent;
  let fixture: ComponentFixture<QuesNavComponent>;

  beforeEach(fakeAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ QuesNavComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QuesNavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
