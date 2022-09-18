# frozen_string_literal: true

require 'rspec'
require 'httparty'

class Helper
  def api_url
    'http://localhost:4567'
  end

  def GetLists
    HTTParty.get("#{api_url}/lists")
  end

  def CreateList(listname)
    HTTParty.post("#{api_url}/lists/add",
                  body: {
                    name: listname
                  }.to_json)
  end

  def DeleteList(number)
    HTTParty.delete("#{api_url}/lists/#{number}")
  end

  def CreateListItem(listNumber, listItemName)
    HTTParty.post("#{api_url}/list/#{listNumber}/add",
                  body: {
                    label: listItemName
                  }.to_json)
  end

  def CompleteListItem(listNumber, listItemNumber, flag)
    HTTParty.post("#{api_url}/list/#{listNumber}/item/#{listItemNumber}/complete/#{flag}")
  end

  def DeleteListItem(listNumber, listItemNumber)
    HTTParty.delete("#{api_url}/list/#{listNumber}/item/#{listItemNumber}")
  end
end
