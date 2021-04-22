import { OpenHrTemplatePage } from './app.po';

describe('OpenHr App', function() {
  let page: OpenHrTemplatePage;

  beforeEach(() => {
    page = new OpenHrTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
