

// don't change those includes
#include "User.h"
#include "RecommendationSystem.h"


// implement your cpp code here
User::User (std::string &name, rank_map &ranks,
            std::shared_ptr<RecommendationSystem> rs)
{
  _name = name;
  _ranks = ranks;
  _rs = rs;
}
void
User::add_movie_to_rs (const std::string &name, int year, const
std::vector<double> &features, double rate)
{
  sp_movie movie = _rs->add_movie(name, year, features);
  _ranks[movie] = rate;
}

sp_movie User::get_recommendation_by_content () const
{
  return _rs->recommend_by_content(*this);
}

double
User::get_prediction_score_for_movie (const std::string &name, int year, int
k) const
{
  sp_movie movie = _rs->get_movie(name, year);
  return _rs->predict_movie_score(*this, movie, k);
}

sp_movie User::get_recommendation_by_cf (int k) const
{
  return _rs->recommend_by_cf(*this, k);
}
std::ostream& operator<< (std::ostream& os, const User& user)
{
  os << "name: " << user._name << std::endl;
  os << *(user._rs)<< std::endl;
  return os;
}