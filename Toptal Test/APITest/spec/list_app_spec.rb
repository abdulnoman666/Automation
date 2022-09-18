require 'httparty'
require 'rspec'
require_relative 'helper_function'

describe 'ListApp' do
  helper = Helper.new
  successCode = 200
  listToDelete = 2
  listNumber = 0
  completeListItem = 2
  incompleteListItem = 1
  listItemName = 'Butter'
  listName = 'APITesting'

  it 'Get All Lists' do
    response = helper.GetLists
    expect(response.code).to eq(successCode)
  end

  it 'Add List' do
    response = helper.CreateList(listName)
    expect(response.code).to eq(successCode)
  end

  it 'Delete List' do
    response = helper.DeleteList(listToDelete)
    expect(response.code).to eq(successCode)
  end

  it 'Add List Item' do
    response = helper.CreateListItem(listNumber, listItemName)
    expect(response.code).to eq(successCode)
  end

  it 'Complete List Item' do
    response = helper.CompleteListItem(listNumber, completeListItem, true)
    expect(response.code).to eq(successCode)
  end

  it 'Make List Item Incomplete' do
    response = helper.CompleteListItem(listNumber, incompleteListItem, false)
    expect(response.code).to eq(successCode)
  end

  it 'Delete List Item' do
    response = helper.DeleteListItem(listNumber, completeListItem)
    expect(response.code).to eq(successCode)
  end
end
