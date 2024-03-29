﻿using _02.MyBlog.Model.CategoryDtos;
using _03.MyBlog.Entities;
using _04.MyBlog.Data.Repositories;
using _05.MyBlog.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MyBlog.Service
{
    public class CategoryManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager()
        {
            _unitOfWork = new UnitOfWork();
        }

        public CategoryDto Get(int categoryId)
        {
            CategoryDto categoryDto = _unitOfWork.CategoryRepository.Get(c => c.Id == categoryId).ToDto();
            return categoryDto;
        }

        public List<CategoryDto> GetAll()
        {
            List<CategoryDto> categoryDtos = _unitOfWork.CategoryRepository.GetAll().ToDto().ToList();
            return categoryDtos;
        }

        public List<CategoryDto> GetAllNonDeleted()
        {
            List<CategoryDto> categoryDtos = _unitOfWork.CategoryRepository.GetAll(c => !c.IsDeleted).ToDto().ToList();
            return categoryDtos;
        }

        public void Add(AddCategoryDto addCategoryDto)
        {
            try
            {
                _unitOfWork.CategoryRepository.Add(addCategoryDto.ToEntity());
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(UpdateCategoryDto updateCategoryDto, int categoryId)
        {
            try
            {
                Category category = _unitOfWork.CategoryRepository.Get(c => c.Id == categoryId);
                category.Name = updateCategoryDto.Name;
                category.Description = updateCategoryDto.Description;
                category.ModifedBy = "Admin";
                category.ModifedDate = DateTime.Now;
                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int categoryId)
        {
            try
            {
                Category category = _unitOfWork.CategoryRepository.Get(c => c.Id == categoryId);
                category.IsDeleted = true;
                category.DeletedDate = DateTime.Now;
                category.DeletedBy = "Admin";
                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SetActive(int categoryId)
        {
            try
            {
                Category category = _unitOfWork.CategoryRepository.Get(c => c.Id == categoryId);
                category.IsDeleted = false;
                category.ModifedBy = "Admin";
                category.ModifedDate = DateTime.Now;

                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
