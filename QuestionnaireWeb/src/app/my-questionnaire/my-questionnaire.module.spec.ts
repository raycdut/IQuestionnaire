import { MyQuestionnaireModule } from './my-questionnaire.module';

describe('MyQuestionnaireModule', () => {
  let myQuestionnaireModule: MyQuestionnaireModule;

  beforeEach(() => {
    myQuestionnaireModule = new MyQuestionnaireModule();
  });

  it('should create an instance', () => {
    expect(myQuestionnaireModule).toBeTruthy();
  });
});
