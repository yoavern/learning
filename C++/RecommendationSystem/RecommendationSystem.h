//
// Created on 2/20/2022.
//

#ifndef RECOMMENDATIONSYSTEM_H
#define RECOMMENDATIONSYSTEM_H
#include "User.h"
#include <map>
#include <cmath>
#include <algorithm>
#define LOWEST_SIM -1.0
struct compare_struct
{
    bool operator()(const sp_movie& m1, const sp_movie& m2) const
    {
        return *m1 < *m2;
    }
};
typedef std::map<sp_movie,std::vector<double>,compare_struct> movie_map;
typedef std::vector<std::pair<sp_movie,double>> similar_vector;
void decrease_average(rank_map &ranks);
void second_step(const rank_map &ranks, std::vector<double> &preference_v,
                 movie_map &movies);
double inner_products(const std::vector<double> &v1, const
std::vector<double> &v2);
double norm(const std::vector<double> &v);
class RecommendationSystem
{
 private:
 movie_map _movies;
public:

	explicit RecommendationSystem()= default;;
    /**
     * adds a new movie to the system
     * @param name name of movie
     * @param year year it was made
     * @param features features for movie
     * @return shared pointer for movie in system
     */
	sp_movie add_movie(const std::string& name,int year,const
    std::vector<double>& features);

    /**
     * a function that calculates the movie with highest score based on
     * movie features
     * @param ranks user ranking to use for algorithm
     * @return shared pointer to movie in system
     */
	sp_movie recommend_by_content(const User& user);

    /**
     * a function that calculates the movie with highest predicted score
     * based on ranking of other movies
     * @param ranks user ranking to use for algorithm
     * @param k
     * @return shared pointer to movie in system
     */
	sp_movie recommend_by_cf(const User& user, int k);


    /**
     * Predict a user rating for a movie given argument using item cf
     * procedure with k most similar movies.
     * @param user_rankings: ranking to use
     * @param movie: movie to predict
     * @param k:
     * @return score based on algorithm as described in pdf
     */
	double predict_movie_score(const User &user, const sp_movie &movie,
												  int k);

	/**
	 * gets a shared pointer to movie in system
	 * @param name name of movie
	 * @param year year movie was made
	 * @return shared pointer to movie in system
	 */
	sp_movie get_movie(const std::string &name, int year) const;


	friend std::ostream& operator<<(std::ostream& os, const
    RecommendationSystem& rs);

};


#endif //RECOMMENDATIONSYSTEM_H
