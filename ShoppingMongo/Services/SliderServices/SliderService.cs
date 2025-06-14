﻿using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Dtos.CategoryDtos;
using ShoppingMongo.Dtos.SliderDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Settings;

namespace ShoppingMongo.Services.SliderServices
{
    public class SliderService : ISliderService
    {

        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;
        public SliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }


        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            await _sliderCollection.InsertOneAsync(value);
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _sliderCollection.DeleteOneAsync(x => x.SliderId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var values = await _sliderCollection.Find(x => true).ToListAsync();//şart olmadan tüm verileri getirir.
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public async Task<GetSliderDto> GetSliderByIdAsync(string id)
        {
            var value = await _sliderCollection.Find(x => x.SliderId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSliderDto>(value);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x => x.SliderId == updateSliderDto.SliderId, value);
        }
    }
}

